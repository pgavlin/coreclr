using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_And_Op_cs_d_Double_And_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_And_Op_cs_d_Double_And_Op_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_And_Op_cs_d\\Double_And_Op_cs_d.cmd");
        }
    }
}
