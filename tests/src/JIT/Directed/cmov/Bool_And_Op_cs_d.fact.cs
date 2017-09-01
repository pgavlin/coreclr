using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Bool_And_Op_cs_d_Bool_And_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_And_Op_cs_d_Bool_And_Op_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_And_Op_cs_d\\Bool_And_Op_cs_d.cmd");
        }
    }
}
