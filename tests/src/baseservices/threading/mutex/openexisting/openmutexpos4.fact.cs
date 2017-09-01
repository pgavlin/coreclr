using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_openexisting_openmutexpos4_openmutexpos4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexpos4_openmutexpos4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexpos4\\openmutexpos4.cmd");
        }
    }
}
