using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Negative_Type_ofT_Inherit_FromT_Type_ofT_Inherit_FromT_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Negative_Type_ofT_Inherit_FromT_Type_ofT_Inherit_FromT_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Negative\\Type_ofT_Inherit_FromT\\Type_ofT_Inherit_FromT.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
