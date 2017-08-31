using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern_test4_xassem_test4_xassem_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern_test4_xassem_test4_xassem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\test4-xassem\\test4-xassem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
