using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_openexisting_openmutexpos1_openmutexpos1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexpos1_openmutexpos1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexpos1\\openmutexpos1.cmd");
        }
    }
}
