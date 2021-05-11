# LL1_grammar_analyzer
LL1 grammar analyzer build on .NET CORE by C#

预测分析表将在语法分析中被自动打印出来（详见StrTrans.cs）需要查看预测分析表，请用下面给出的测试用例输入运行

if-else grammer analyze

<条件语句> → IF <条件> THEN <语句> 
<条件> → <表达式> <关系运算符> <表达式>
<关系运算符>  → > | < | =
<语句> → <id> := <表达式>
<表达式> → <项>+ <项> | <项>- <项>| <项>
<项> → <因子>*<因子> | <因子>/<因子>| <因子>
<因子> → <id> |<num> |(<表达式>)
其中<id>表示标识符，<num>表示无符号数字。

S：条件语句
A：条件
B：语句
C：表达式
D：关系运算符
E：项
F：因子
if：x
then：y
标识符：i
数字：n
:=：e
@：空串


grammer:
S->xAyB
A->CDC
D->>|<|=
B->ieC
C->EG
G->+E|-E|@
E->FH
H->*F|/F|@
F->i|n|(C)

Here are some example test cases.

#############

(IF,   x)
(IDENTIFIER,    i)
(MORE ,       >)
(NUM,  n )
(THEN, y )
(IDENTIFIER,    i)
(ASSIGN, e )
(NUM,  n )

###########

(IF,   x)
(IDENTIFIER,    i)
(MORE ,       >)
(NUM,  n )
(THEN, y )
(IDENTIFIER,    i)
(ASSIGN, e )
(PAREN,  ( )
(IDENTIFIER,    i)
(PLUS,   +)
(NUM,  n )



#############

(IF,   x)
(IDENTIFIER,    i)
(MORE ,       >)
(NUM,  n )
(THEN, y )
(IDENTIFIER,    i)
(ASSIGN, e )
(PAREN,  ( )
(IDENTIFIER,    i)
(MUL, *)
(PAREN,  ( )
(IDENTIFIER,    i)
(MINUS,   -)
(NUM,  n )
(PAREN,  ) )
(PAREN,  ) )


############


