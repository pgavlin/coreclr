using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_And_Op_cs_do_Bool_And_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_And_Op_cs_do_Bool_And_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_And_Op_cs_do\\Bool_And_Op_cs_do.cmd");
        }
    }
}
