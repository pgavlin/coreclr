using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XAssemblytest4_xassem__XAssemblytest4_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XAssemblytest4_xassem__XAssemblytest4_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XAssemblytest4-xassem\\_XAssemblytest4-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
