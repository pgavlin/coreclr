using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_Baadbaad_Baadbaad_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_Baadbaad_Baadbaad_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\Baadbaad\\Baadbaad.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
