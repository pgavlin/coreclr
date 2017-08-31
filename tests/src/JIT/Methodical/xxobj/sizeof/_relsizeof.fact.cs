using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__relsizeof__relsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__relsizeof__relsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_relsizeof\\_relsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
