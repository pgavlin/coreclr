using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_And_Op_cs_do_Double_And_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_And_Op_cs_do_Double_And_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_And_Op_cs_do\\Double_And_Op_cs_do.cmd");
        }
    }
}
