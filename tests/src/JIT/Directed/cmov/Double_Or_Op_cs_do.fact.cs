using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_Or_Op_cs_do_Double_Or_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_Or_Op_cs_do_Double_Or_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_Or_Op_cs_do\\Double_Or_Op_cs_do.cmd");
        }
    }
}
