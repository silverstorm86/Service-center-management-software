using Projector_service_app;

namespace c
{
    internal class BinaryDeserialize : Customer
    {
        private Customer cs;

        public BinaryDeserialize(ref Customer cs)
        {
            this.cs = cs;
        }
    }
}