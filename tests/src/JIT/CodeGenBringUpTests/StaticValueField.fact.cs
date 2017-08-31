using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _StaticValueField_StaticValueField_
    {
        [OuterLoop]
        [Fact]
        public void _StaticValueField_StaticValueField_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StaticValueField\\StaticValueField.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
