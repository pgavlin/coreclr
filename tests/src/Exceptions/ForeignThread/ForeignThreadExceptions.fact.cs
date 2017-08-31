using CoreclrTestLib;
using Xunit;

namespace Exceptions_ForeignThread
{
    class _ForeignThreadExceptions_ForeignThreadExceptions_
    {
        [Fact]
        public void _ForeignThreadExceptions_ForeignThreadExceptions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Exceptions\\ForeignThread\\ForeignThreadExceptions\\ForeignThreadExceptions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
