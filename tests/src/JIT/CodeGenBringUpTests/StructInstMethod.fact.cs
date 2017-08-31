using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _StructInstMethod_StructInstMethod_
    {
        [OuterLoop]
        [Fact]
        public void _StructInstMethod_StructInstMethod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StructInstMethod\\StructInstMethod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
