using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_Xor_Op_cs_r_Float_Xor_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_Xor_Op_cs_r_Float_Xor_Op_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_Xor_Op_cs_r\\Float_Xor_Op_cs_r.cmd");
        }
    }
}
