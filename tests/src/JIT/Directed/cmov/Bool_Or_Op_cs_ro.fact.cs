using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_Or_Op_cs_ro_Bool_Or_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_Or_Op_cs_ro_Bool_Or_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_Or_Op_cs_ro\\Bool_Or_Op_cs_ro.cmd");
        }
    }
}
