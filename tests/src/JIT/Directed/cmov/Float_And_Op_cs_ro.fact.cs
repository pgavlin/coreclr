using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_And_Op_cs_ro_Float_And_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_And_Op_cs_ro_Float_And_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_And_Op_cs_ro\\Float_And_Op_cs_ro.cmd");
        }
    }
}
