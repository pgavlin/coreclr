using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_Xor_Op_cs_d_Float_Xor_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_Xor_Op_cs_d_Float_Xor_Op_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_Xor_Op_cs_d\\Float_Xor_Op_cs_d.cmd");
        }
    }
}
