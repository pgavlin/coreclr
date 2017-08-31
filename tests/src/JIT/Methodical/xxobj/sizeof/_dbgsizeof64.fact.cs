using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__dbgsizeof64__dbgsizeof64_
    {
        [Fact]
        public void _xxobj_sizeof__dbgsizeof64__dbgsizeof64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_dbgsizeof64\\_dbgsizeof64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
