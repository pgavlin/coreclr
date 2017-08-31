using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_misc_derivedExplicitClass_derivedExplicitClass_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_misc_derivedExplicitClass_derivedExplicitClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\misc\\derivedExplicitClass\\derivedExplicitClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
