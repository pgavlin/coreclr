using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_No_Op_cs_r_Bool_No_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_No_Op_cs_r_Bool_No_Op_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_No_Op_cs_r\\Bool_No_Op_cs_r.cmd");
        }
    }
}
