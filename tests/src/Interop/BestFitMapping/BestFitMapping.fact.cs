using CoreclrTestLib;
using Xunit;

namespace Interop_BestFitMapping
{
    class _BestFitMapping_BestFitMapping_
    {
        [OuterLoop]
        [Fact]
        public void _BestFitMapping_BestFitMapping_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\BestFitMapping\\BestFitMapping\\BestFitMapping.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
