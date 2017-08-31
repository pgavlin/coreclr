using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_openexisting_openmutexneg2_openmutexneg2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg2_openmutexneg2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg2\\openmutexneg2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
