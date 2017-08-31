using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_openexisting_openmutexpos2_openmutexpos2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexpos2_openmutexpos2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexpos2\\openmutexpos2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
