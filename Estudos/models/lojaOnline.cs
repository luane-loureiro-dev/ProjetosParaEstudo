namespace lojaOnline
{
    public class Estoque
    {
        public int quantidadeEmEstoque = 10;

        public bool PodeVender(int quantidadeSolicitada)
        {
            if (quantidadeSolicitada > quantidadeEmEstoque)
            {
                return false;
            }
            return true;
        }
    }
}