using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_Or_Op_cs_ro_Float_Or_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_Or_Op_cs_ro_Float_Or_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_Or_Op_cs_ro\\Float_Or_Op_cs_ro.cmd");
        }
    }
}
