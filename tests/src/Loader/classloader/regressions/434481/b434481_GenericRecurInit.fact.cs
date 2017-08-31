using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_434481_b434481_GenericRecurInit_b434481_GenericRecurInit_
    {
        [Fact]
        public void _regressions_434481_b434481_GenericRecurInit_b434481_GenericRecurInit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\434481\\b434481_GenericRecurInit\\b434481_GenericRecurInit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
