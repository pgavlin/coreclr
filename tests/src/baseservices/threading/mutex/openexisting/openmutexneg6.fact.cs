using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_openexisting_openmutexneg6_openmutexneg6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg6_openmutexneg6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg6\\openmutexneg6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
