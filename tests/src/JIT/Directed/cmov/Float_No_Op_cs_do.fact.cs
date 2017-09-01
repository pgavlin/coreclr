using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Float_No_Op_cs_do_Float_No_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_No_Op_cs_do_Float_No_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_No_Op_cs_do\\Float_No_Op_cs_do.cmd");
        }
    }
}
