using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__XAssemblytest1_xassem__XAssemblytest1_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__XAssemblytest1_xassem__XAssemblytest1_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_XAssemblytest1-xassem\\_XAssemblytest1-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
