using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Double_Xor_Op_cs_r_Double_Xor_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_Xor_Op_cs_r_Double_Xor_Op_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_Xor_Op_cs_r\\Double_Xor_Op_cs_r.cmd");
        }
    }
}
