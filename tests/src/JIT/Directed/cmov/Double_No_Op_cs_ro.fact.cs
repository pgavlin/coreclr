using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_No_Op_cs_ro_Double_No_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_No_Op_cs_ro_Double_No_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_No_Op_cs_ro\\Double_No_Op_cs_ro.cmd");
        }
    }
}
