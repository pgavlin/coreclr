using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _struct16args_struct16args_
    {
        [OuterLoop]
        [Fact]
        public void _struct16args_struct16args_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\struct16args\\struct16args.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
