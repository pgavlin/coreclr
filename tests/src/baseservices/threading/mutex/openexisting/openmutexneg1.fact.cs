using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_openexisting_openmutexneg1_openmutexneg1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg1_openmutexneg1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg1\\openmutexneg1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
