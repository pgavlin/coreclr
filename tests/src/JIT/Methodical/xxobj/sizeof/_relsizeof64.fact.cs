using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__relsizeof64__relsizeof64_
    {
        [Fact]
        public void _xxobj_sizeof__relsizeof64__relsizeof64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_relsizeof64\\_relsizeof64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
