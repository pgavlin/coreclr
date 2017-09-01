using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Int_Xor_Op_cs_d_Int_Xor_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_Xor_Op_cs_d_Int_Xor_Op_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_Xor_Op_cs_d\\Int_Xor_Op_cs_d.cmd");
        }
    }
}
