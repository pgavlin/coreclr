using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_MRENullRefEx_CS_MRENullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_MRENullRefEx_CS_MRENullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_MRENullRefEx\\CS_MRENullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
