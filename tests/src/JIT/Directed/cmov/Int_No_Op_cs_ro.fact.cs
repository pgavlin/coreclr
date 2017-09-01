using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Int_No_Op_cs_ro_Int_No_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_No_Op_cs_ro_Int_No_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_No_Op_cs_ro\\Int_No_Op_cs_ro.cmd");
        }
    }
}
