using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_No_Op_cs_ro_Float_No_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_No_Op_cs_ro_Float_No_Op_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_No_Op_cs_ro\\Float_No_Op_cs_ro.cmd");
        }
    }
}
