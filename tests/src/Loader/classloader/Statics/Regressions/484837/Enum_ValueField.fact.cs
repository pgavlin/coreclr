using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _Statics_Regressions_484837_Enum_ValueField_Enum_ValueField_
    {
        [OuterLoop]
        [Fact]
        public void _Statics_Regressions_484837_Enum_ValueField_Enum_ValueField_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\Statics\\Regressions\\484837\\Enum_ValueField\\Enum_ValueField.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
