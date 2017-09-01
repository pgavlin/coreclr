using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Int_No_Op_cs_r_Int_No_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_No_Op_cs_r_Int_No_Op_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_No_Op_cs_r\\Int_No_Op_cs_r.cmd");
        }
    }
}
