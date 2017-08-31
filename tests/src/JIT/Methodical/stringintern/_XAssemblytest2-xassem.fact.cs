using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XAssemblytest2_xassem__XAssemblytest2_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XAssemblytest2_xassem__XAssemblytest2_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XAssemblytest2-xassem\\_XAssemblytest2-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
