using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_simpvariant_simpvariant_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_simpvariant_simpvariant_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\simpvariant\\simpvariant.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
