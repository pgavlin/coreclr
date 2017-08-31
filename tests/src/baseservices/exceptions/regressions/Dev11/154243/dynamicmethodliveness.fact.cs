using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_Dev11_154243_dynamicmethodliveness_dynamicmethodliveness_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_Dev11_154243_dynamicmethodliveness_dynamicmethodliveness_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\Dev11\\154243\\dynamicmethodliveness\\dynamicmethodliveness.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
