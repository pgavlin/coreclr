using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_openexisting_openmutexneg5_openmutexneg5_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg5_openmutexneg5_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg5\\openmutexneg5.cmd");
        }
    }
}
