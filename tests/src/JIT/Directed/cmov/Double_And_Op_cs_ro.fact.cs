using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_And_Op_cs_ro_Double_And_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_And_Op_cs_ro_Double_And_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_And_Op_cs_ro\\Double_And_Op_cs_ro.cmd");
        }
    }
}
