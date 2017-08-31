using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_openexisting_openmutexneg3_openmutexneg3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg3_openmutexneg3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg3\\openmutexneg3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
