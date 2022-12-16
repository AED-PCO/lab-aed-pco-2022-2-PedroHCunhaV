class Nodo
{
    public Nodo TesteDireito = null;
    public Nodo TesteEquerdo = null;
    public int valorNodo;
}

class Arvore
{
    public void inserir(int valor, Nodo nodo)
    {
        if (valor > nodo.valorNodo)
        {
            if (nodo.TesteDireito == null)
            {
                Nodo Filhos = new Nodo();
                Filhos.valorNodo = valor;
                nodo.TesteDireito = Filhos;
            }
            else
            {
                inserir(valor, nodo.TesteDireito);
            }
        }
        else
        {
            if (nodo.TesteEquerdo == null)
            {
                Nodo Filhos = new Nodo();
                Filhos.valorNodo = valor;
                nodo.TesteEquerdo = Filhos;
            }
            else
            {
                inserir(valor, nodo.TesteEquerdo);
            }
        }
    }

    static void Main()
    {
        Nodo raiz = new Nodo();
        raiz.valorNodo = 10;

        Arvore arvore = new Arvore();
        arvore.inserir(5,raiz);
        arvore.inserir(6, raiz);
        arvore.inserir(8, raiz);
    }

}

