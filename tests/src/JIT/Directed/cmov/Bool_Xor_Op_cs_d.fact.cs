using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_Xor_Op_cs_d_Bool_Xor_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_Xor_Op_cs_d_Bool_Xor_Op_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_Xor_Op_cs_d\\Bool_Xor_Op_cs_d.cmd");
        }
    }
}
