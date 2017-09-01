using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_And_Op_cs_r_Double_And_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_And_Op_cs_r_Double_And_Op_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_And_Op_cs_r\\Double_And_Op_cs_r.cmd");
        }
    }
}
