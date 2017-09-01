using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_Xor_Op_cs_do_Bool_Xor_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_Xor_Op_cs_do_Bool_Xor_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_Xor_Op_cs_do\\Bool_Xor_Op_cs_do.cmd");
        }
    }
}
