using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_And_Op_cs_ro_Bool_And_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_And_Op_cs_ro_Bool_And_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_And_Op_cs_ro\\Bool_And_Op_cs_ro.cmd");
        }
    }
}
