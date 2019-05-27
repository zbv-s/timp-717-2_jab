#include "stdio.h"
#include "stdlib.h"

    typedef struct node{
        int value;
        struct node* prev;
        struct node* left;
        struct node* right;
    }node;

    typedef struct tree{
      struct node* root;
      int count;
    }tree;

    typedef struct list_node{
        struct node *value;
        struct list_node *next;
    }list_node;

    typedef struct list{
        list_node *tail;
        list_node *head;
    }list;

    void list_init(list* l){
        l->head = NULL;
        l->tail = NULL;
    }

    int list_isEmpty(list *l){
      int flag = (l->tail==NULL);
      return flag;
    }

    int push_back(list *l,node *value){
        list_node *temp_l = malloc(sizeof(list_node));
        temp_l->value = value;
        temp_l->next = NULL;

        if(!list_isEmpty(l)){
          l->tail->next = temp_l;
          l->tail = temp_l;
        }
                else{
          l->head = l->tail = temp_l;
        }
    }

    node* removeFirst(list *l){
                list_node *headptr = l->head;
                node *temp = l->head->value;

                l->head = l->head->next;

                if (l->head == NULL){
                        l->tail = NULL;
                }
                free(headptr);
                return temp;
    }

    int flagEmpty(list *l){
                list_node *headptr = l->head;
                while(headptr!=NULL){
                        if (headptr->value != NULL) {
                                return 0;
                        }

                        headptr = headptr->next;
        }
                return 1;
    }

    void listPrint(list *l){
                list_node *headptr = l->head;
                while(headptr){
                        if (!headptr->value) {
                                printf("_");
                        }
                        else printf("%d",headptr->value->value);

                        if (headptr->next) {
                                printf(" ");
                        }

                        headptr = headptr->next;
                }
                printf("\n");
    }


    void clear(tree *t,list *l) {
                node *rootptr = t->root;
                node *temp;
                push_back(l,rootptr);
        while(list_isEmpty(l)) {
                        temp = rootptr;
                        rootptr = removeFirst(l);
                        free(temp);

                        if(temp->left != NULL) {
                                push_back(l,rootptr->left);
                        }
                        else if(temp->right!=NULL) {
                                push_back(l,temp->right);
                        }
                }
        t->root = NULL;
    }

    void init(tree *t) {
        t->count = 0;
        t->root = NULL;
    }

   int find(tree *t,int value,node *n) {
       node *nodeptr = t->root;
       if(!nodeptr){
                   return 1;
           }
       else{
           while(nodeptr!=NULL) {
               if(value > nodeptr->value){
                                        nodeptr = nodeptr->right;
                                        continue;
               }
               if(value < nodeptr->value){
                                        nodeptr = nodeptr->left;
                                                continue;
               }
               if (value == nodeptr->value){
                                   if (n == NULL) {
                                                return 0;
                                   }
                   else {
                                                printf("there");
                                                n = nodeptr;
                                                printf("in function find %p\n",n);
                                                return 0;
                                   }
               }
           }
       }
       return 1;
   }

  int insert(tree *t, int value){
          if (!t->root) {
                  node *temp = malloc(sizeof(node)); if (!temp) { return 2; }
                  temp->value = value;
                  temp->right = NULL;
                  temp->left = NULL;
                  temp->prev = NULL;
                  t->root = temp;
                  (t->count)++;
                  return 0;
          }

          if (!find(t, value, NULL)) {
                  return 1;
          }
          else{
                  node *prevptr;
                  node *ptr = t->root;
                  while (ptr){
                          prevptr = ptr;

                          if (value < ptr->value){
                                  if (!ptr->left){
                                          node *temp = malloc(sizeof(node));
                                          if (!temp) {
                                                  return 2;
                                          }
                                          temp->value = value;
                                          temp->left = NULL;
                                          temp->right = NULL;
                                          temp->prev = prevptr;
                                          prevptr->left = temp;

                                          t->count++;
                                          return 0;
                                  }
                                  else{
                                          ptr = ptr->left;
                                          continue;
                                  }
                          }
                          else{
                                  if (!ptr->right){
                                          node *temp = malloc(sizeof(node));
                                          temp->value = value;
                                          temp->left = NULL;
                                          temp->right = NULL;
                                          temp->prev = prevptr;
                                          prevptr->right = temp;
                                          t->count++;
                                          return 0;
                                  }
                                  else{
                                          ptr = ptr->right;
                                          continue;
                                  }
                          }
                  }

          }
          return 1;
  }

  void print(node *n, list *l){
          node *rootptr = n;
          list *l_temp = malloc(sizeof(list));

          if (!rootptr){
                  printf("-\n");
                  return;
          }

          push_back(l, rootptr);
          listPrint(l);

          while(1){
                  while (!list_isEmpty(l)){
                          rootptr = removeFirst(l);
                          push_back(l_temp, rootptr);
                  }

                  while (!list_isEmpty(l_temp)){
                          rootptr = removeFirst(l_temp);
                          if (rootptr == NULL){
                                  push_back(l, NULL);
                                  push_back(l, NULL);
                          }
                          else{
                                  push_back(l, rootptr->left);
                                  push_back(l, rootptr->right);
                          }

                  }
                  if (flagEmpty(l)){
                          while (!list_isEmpty(l)) {
                                  removeFirst(l);
                          }
                          break;
                  }
                  listPrint(l);
          }
  }

  void printTree(tree *t, list *l){
        node *rootptr = t->root;
        int count = 0;
        push_back(l, rootptr);
        while (!list_isEmpty(l)){
                node *tmp = removeFirst(l);
                count++;
                if (count != t->count) {
                    printf("%d ", tmp->value);
                }
                else{
                    printf("%d\n", tmp->value);
                }

                if (tmp->left){
                    push_back(l, tmp->left);
                }
                if (tmp->right){
                    push_back(l, tmp->right);
                }
        }

  }
  /*
  void test(tree *t) {
          node *ptr = t->root;
          while (ptr) {
                  printf("val :%d left:%p right:%p prev:%p\n", ptr->value, ptr->left, ptr->right, ptr->prev);
                  ptr = ptr->right;
          }
  }
  */
  int main() {
          tree *t = malloc(sizeof(tree));
          list *l = malloc(sizeof(list));

          init(t);
          list_init(l);

          for (int i = 0; i < 7; ++i){
                int a;
                scanf("%d", &a);
                insert(t, a);
          }
          printTree(t, l);
  }

