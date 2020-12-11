namespace POO_PolimosrfismoSobreposicao.classes
{
    public abstract class Player
    {
        private float velocidade;

        private float forcaPulo;

        public virtual string Correr(){
            return "Correndo em velocidade 1x";
        }

         public virtual string Pular(){
            return "Pula 1 metro";
        }
    }
}