using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _cmov_Int_And_Op_cs_do_Int_And_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_And_Op_cs_do_Int_And_Op_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_And_Op_cs_do\\Int_And_Op_cs_do.cmd");
        }
    }
}
