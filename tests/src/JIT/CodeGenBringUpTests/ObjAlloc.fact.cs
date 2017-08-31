using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ObjAlloc_ObjAlloc_
    {
        [OuterLoop]
        [Fact]
        public void _ObjAlloc_ObjAlloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ObjAlloc\\ObjAlloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
