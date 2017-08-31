using CoreclrTestLib;
using Xunit;

namespace Interop_SizeConst
{
    class _SizeConstTest_SizeConstTest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _SizeConstTest_SizeConstTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\SizeConst\\SizeConstTest\\SizeConstTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
