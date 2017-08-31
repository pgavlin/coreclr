using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _modulector_runmoduleconstructor_runmoduleconstructor_
    {
        [OuterLoop]
        [Fact]
        public void _modulector_runmoduleconstructor_runmoduleconstructor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\modulector\\runmoduleconstructor\\runmoduleconstructor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
